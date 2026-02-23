using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Chanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Chanidae.Chanos;

/// <summary>
/// Abstract class for Chanos (genus).
/// NCBI TaxId: 29143
/// </summary>
public abstract class Chanos : Chanidae, IChanos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chanos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29143;

    /// <inheritdoc />
    public virtual string GenusName => "Chanos";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}

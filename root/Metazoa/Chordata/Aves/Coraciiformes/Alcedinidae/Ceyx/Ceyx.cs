using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Ceyx;

/// <summary>
/// Abstract class for Ceyx (genus).
/// NCBI TaxId: 57403
/// </summary>
public abstract class Ceyx : Alcedinidae, ICeyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ceyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57403;

    /// <inheritdoc />
    public virtual string GenusName => "Ceyx";

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

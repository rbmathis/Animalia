using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Lewinia;

/// <summary>
/// Abstract class for Lewinia (genus).
/// NCBI TaxId: 1150671
/// </summary>
public abstract class Lewinia : Rallidae, ILewinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lewinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1150671;

    /// <inheritdoc />
    public virtual string GenusName => "Lewinia";

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

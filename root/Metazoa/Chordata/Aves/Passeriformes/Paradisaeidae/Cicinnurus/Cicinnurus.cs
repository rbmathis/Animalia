using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae.Cicinnurus;

/// <summary>
/// Abstract class for Cicinnurus (genus).
/// NCBI TaxId: 36262
/// </summary>
public abstract class Cicinnurus : Paradisaeidae, ICicinnurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cicinnurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36262;

    /// <inheritdoc />
    public virtual string GenusName => "Cicinnurus";

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

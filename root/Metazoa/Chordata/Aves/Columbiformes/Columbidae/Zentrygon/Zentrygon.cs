using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Zentrygon;

/// <summary>
/// Abstract class for Zentrygon (genus).
/// NCBI TaxId: 1471558
/// </summary>
public abstract class Zentrygon : Columbidae, IZentrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zentrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1471558;

    /// <inheritdoc />
    public virtual string GenusName => "Zentrygon";

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

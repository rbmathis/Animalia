using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Leptotrygon;

/// <summary>
/// Abstract class for Leptotrygon (genus).
/// NCBI TaxId: 1471557
/// </summary>
public abstract class Leptotrygon : Columbidae, ILeptotrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptotrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1471557;

    /// <inheritdoc />
    public virtual string GenusName => "Leptotrygon";

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

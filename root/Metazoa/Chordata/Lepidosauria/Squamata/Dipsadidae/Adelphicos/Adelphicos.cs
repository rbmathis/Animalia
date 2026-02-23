using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Adelphicos;

/// <summary>
/// Abstract class for Adelphicos (genus).
/// NCBI TaxId: 699566
/// </summary>
public abstract class Adelphicos : Dipsadidae, IAdelphicos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Adelphicos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 699566;

    /// <inheritdoc />
    public virtual string GenusName => "Adelphicos";

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

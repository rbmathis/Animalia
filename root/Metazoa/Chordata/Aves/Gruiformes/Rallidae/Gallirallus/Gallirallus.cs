using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Gallirallus;

/// <summary>
/// Abstract class for Gallirallus (genus).
/// NCBI TaxId: 9124
/// </summary>
public abstract class Gallirallus : Rallidae, IGallirallus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gallirallus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9124;

    /// <inheritdoc />
    public virtual string GenusName => "Gallirallus";

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

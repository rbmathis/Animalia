using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felidae_incertae_sedis.Homotherium;

/// <summary>
/// Abstract class for Homotherium (genus).
/// NCBI TaxId: 339613
/// </summary>
public abstract class Homotherium : Felidae_incertae_sedis, IHomotherium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Homotherium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 339613;

    /// <inheritdoc />
    public virtual string GenusName => "Homotherium";

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

using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Oreomystis;

/// <summary>
/// Abstract class for Oreomystis (genus).
/// NCBI TaxId: 64805
/// </summary>
public abstract class Oreomystis : Fringillidae, IOreomystis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreomystis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 64805;

    /// <inheritdoc />
    public virtual string GenusName => "Oreomystis";

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

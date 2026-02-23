using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Psammodynastes;

/// <summary>
/// Abstract class for Psammodynastes (genus).
/// NCBI TaxId: 186597
/// </summary>
public abstract class Psammodynastes : Colubridae, IPsammodynastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psammodynastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186597;

    /// <inheritdoc />
    public virtual string GenusName => "Psammodynastes";

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

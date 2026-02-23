using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Seminatrix;

/// <summary>
/// Abstract class for Seminatrix (genus).
/// NCBI TaxId: 183603
/// </summary>
public abstract class Seminatrix : Colubridae, ISeminatrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Seminatrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183603;

    /// <inheritdoc />
    public virtual string GenusName => "Seminatrix";

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

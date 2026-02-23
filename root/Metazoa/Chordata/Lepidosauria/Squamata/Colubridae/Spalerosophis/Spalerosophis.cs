using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Spalerosophis;

/// <summary>
/// Abstract class for Spalerosophis (genus).
/// NCBI TaxId: 166083
/// </summary>
public abstract class Spalerosophis : Colubridae, ISpalerosophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spalerosophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166083;

    /// <inheritdoc />
    public virtual string GenusName => "Spalerosophis";

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

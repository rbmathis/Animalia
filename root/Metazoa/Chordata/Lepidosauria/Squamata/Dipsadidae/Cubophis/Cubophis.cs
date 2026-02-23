using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Cubophis;

/// <summary>
/// Abstract class for Cubophis (genus).
/// NCBI TaxId: 1260296
/// </summary>
public abstract class Cubophis : Dipsadidae, ICubophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cubophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1260296;

    /// <inheritdoc />
    public virtual string GenusName => "Cubophis";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Danacetichthys;

/// <summary>
/// Abstract class for Danacetichthys (genus).
/// NCBI TaxId: 143335
/// </summary>
public abstract class Danacetichthys : Cetomimidae, IDanacetichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Danacetichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143335;

    /// <inheritdoc />
    public virtual string GenusName => "Danacetichthys";

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

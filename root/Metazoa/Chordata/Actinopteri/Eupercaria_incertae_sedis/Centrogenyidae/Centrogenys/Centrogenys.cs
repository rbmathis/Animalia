using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Centrogenyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Centrogenyidae.Centrogenys;

/// <summary>
/// Abstract class for Centrogenys (genus).
/// NCBI TaxId: 274788
/// </summary>
public abstract class Centrogenys : Centrogenyidae, ICentrogenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centrogenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274788;

    /// <inheritdoc />
    public virtual string GenusName => "Centrogenys";

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

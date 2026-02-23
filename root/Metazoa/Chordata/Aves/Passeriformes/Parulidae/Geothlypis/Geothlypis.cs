using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Geothlypis;

/// <summary>
/// Abstract class for Geothlypis (genus).
/// NCBI TaxId: 135432
/// </summary>
public abstract class Geothlypis : Parulidae, IGeothlypis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geothlypis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135432;

    /// <inheritdoc />
    public virtual string GenusName => "Geothlypis";

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

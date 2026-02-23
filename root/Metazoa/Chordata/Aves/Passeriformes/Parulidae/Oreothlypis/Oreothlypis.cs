using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Oreothlypis;

/// <summary>
/// Abstract class for Oreothlypis (genus).
/// NCBI TaxId: 1329383
/// </summary>
public abstract class Oreothlypis : Parulidae, IOreothlypis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreothlypis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1329383;

    /// <inheritdoc />
    public virtual string GenusName => "Oreothlypis";

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

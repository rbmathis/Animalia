using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Dermophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Dermophiidae.Geotrypetes;

/// <summary>
/// Abstract class for Geotrypetes (genus).
/// NCBI TaxId: 260994
/// </summary>
public abstract class Geotrypetes : Dermophiidae, IGeotrypetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geotrypetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 260994;

    /// <inheritdoc />
    public virtual string GenusName => "Geotrypetes";

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

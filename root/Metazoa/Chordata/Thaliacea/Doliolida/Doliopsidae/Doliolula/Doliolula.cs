using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliopsidae.Doliolula;

/// <summary>
/// Abstract class for Doliolula (genus).
/// NCBI TaxId: 3065379
/// </summary>
public abstract class Doliolula : Doliopsidae, IDoliolula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Doliolula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3065379;

    /// <inheritdoc />
    public virtual string GenusName => "Doliolula";

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

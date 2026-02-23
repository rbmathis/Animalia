using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Copiula;

/// <summary>
/// Abstract class for Copiula (genus).
/// NCBI TaxId: 83968
/// </summary>
public abstract class Copiula : Microhylidae, ICopiula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Copiula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83968;

    /// <inheritdoc />
    public virtual string GenusName => "Copiula";

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

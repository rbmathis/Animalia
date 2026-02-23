using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Stephanolepis;

/// <summary>
/// Abstract class for Stephanolepis (genus).
/// NCBI TaxId: 143347
/// </summary>
public abstract class Stephanolepis : Monacanthidae, IStephanolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stephanolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143347;

    /// <inheritdoc />
    public virtual string GenusName => "Stephanolepis";

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

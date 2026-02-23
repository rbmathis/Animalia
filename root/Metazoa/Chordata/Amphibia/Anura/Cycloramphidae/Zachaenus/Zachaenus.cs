using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Cycloramphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Cycloramphidae.Zachaenus;

/// <summary>
/// Abstract class for Zachaenus (genus).
/// NCBI TaxId: 613080
/// </summary>
public abstract class Zachaenus : Cycloramphidae, IZachaenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zachaenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 613080;

    /// <inheritdoc />
    public virtual string GenusName => "Zachaenus";

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

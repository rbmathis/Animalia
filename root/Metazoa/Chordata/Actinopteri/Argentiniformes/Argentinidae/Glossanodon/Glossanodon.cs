using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Argentinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Argentinidae.Glossanodon;

/// <summary>
/// Abstract class for Glossanodon (genus).
/// NCBI TaxId: 170195
/// </summary>
public abstract class Glossanodon : Argentinidae, IGlossanodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glossanodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 170195;

    /// <inheritdoc />
    public virtual string GenusName => "Glossanodon";

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

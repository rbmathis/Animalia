using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heteropneustidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heteropneustidae.Heteropneustes;

/// <summary>
/// Abstract class for Heteropneustes (genus).
/// NCBI TaxId: 93620
/// </summary>
public abstract class Heteropneustes : Heteropneustidae, IHeteropneustes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteropneustes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 93620;

    /// <inheritdoc />
    public virtual string GenusName => "Heteropneustes";

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

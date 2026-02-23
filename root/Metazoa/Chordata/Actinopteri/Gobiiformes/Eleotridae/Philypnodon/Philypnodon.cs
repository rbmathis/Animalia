using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Philypnodon;

/// <summary>
/// Abstract class for Philypnodon (genus).
/// NCBI TaxId: 150316
/// </summary>
public abstract class Philypnodon : Eleotridae, IPhilypnodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Philypnodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150316;

    /// <inheritdoc />
    public virtual string GenusName => "Philypnodon";

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

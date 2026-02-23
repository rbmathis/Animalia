using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Canthidermis;

/// <summary>
/// Abstract class for Canthidermis (genus).
/// NCBI TaxId: 303690
/// </summary>
public abstract class Canthidermis : Balistidae, ICanthidermis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Canthidermis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303690;

    /// <inheritdoc />
    public virtual string GenusName => "Canthidermis";

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

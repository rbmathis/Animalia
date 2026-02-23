using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chetia;

/// <summary>
/// Abstract class for Chetia (genus).
/// NCBI TaxId: 311499
/// </summary>
public abstract class Chetia : Cichlidae, IChetia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chetia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 311499;

    /// <inheritdoc />
    public virtual string GenusName => "Chetia";

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

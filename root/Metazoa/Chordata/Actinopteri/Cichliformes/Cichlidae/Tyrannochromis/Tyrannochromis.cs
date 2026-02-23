using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tyrannochromis;

/// <summary>
/// Abstract class for Tyrannochromis (genus).
/// NCBI TaxId: 40197
/// </summary>
public abstract class Tyrannochromis : Cichlidae, ITyrannochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tyrannochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40197;

    /// <inheritdoc />
    public virtual string GenusName => "Tyrannochromis";

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

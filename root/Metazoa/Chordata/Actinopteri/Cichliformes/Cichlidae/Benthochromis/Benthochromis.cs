using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Benthochromis;

/// <summary>
/// Abstract class for Benthochromis (genus).
/// NCBI TaxId: 158759
/// </summary>
public abstract class Benthochromis : Cichlidae, IBenthochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Benthochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 158759;

    /// <inheritdoc />
    public virtual string GenusName => "Benthochromis";

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

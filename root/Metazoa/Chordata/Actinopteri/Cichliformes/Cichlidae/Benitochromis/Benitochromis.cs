using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Benitochromis;

/// <summary>
/// Abstract class for Benitochromis (genus).
/// NCBI TaxId: 446521
/// </summary>
public abstract class Benitochromis : Cichlidae, IBenitochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Benitochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 446521;

    /// <inheritdoc />
    public virtual string GenusName => "Benitochromis";

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

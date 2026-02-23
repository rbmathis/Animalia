using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Prognathochromis;

/// <summary>
/// Abstract class for Prognathochromis (genus).
/// NCBI TaxId: 77309
/// </summary>
public abstract class Prognathochromis : Cichlidae, IPrognathochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prognathochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 77309;

    /// <inheritdoc />
    public virtual string GenusName => "Prognathochromis";

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

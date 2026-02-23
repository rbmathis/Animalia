using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nemichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nemichthyidae.Avocettina;

/// <summary>
/// Abstract class for Avocettina (genus).
/// NCBI TaxId: 121279
/// </summary>
public abstract class Avocettina : Nemichthyidae, IAvocettina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Avocettina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121279;

    /// <inheritdoc />
    public virtual string GenusName => "Avocettina";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Glossamia;

/// <summary>
/// Abstract class for Glossamia (genus).
/// NCBI TaxId: 638235
/// </summary>
public abstract class Glossamia : Apogonidae, IGlossamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glossamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 638235;

    /// <inheritdoc />
    public virtual string GenusName => "Glossamia";

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

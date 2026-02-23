using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Heteroscenes;

/// <summary>
/// Abstract class for Heteroscenes (genus).
/// NCBI TaxId: 3473409
/// </summary>
public abstract class Heteroscenes : Cuculidae, IHeteroscenes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteroscenes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3473409;

    /// <inheritdoc />
    public virtual string GenusName => "Heteroscenes";

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

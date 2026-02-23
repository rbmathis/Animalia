using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae.Capito;

/// <summary>
/// Abstract class for Capito (genus).
/// NCBI TaxId: 91764
/// </summary>
public abstract class Capito : Ramphastidae, ICapito
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Capito";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91764;

    /// <inheritdoc />
    public virtual string GenusName => "Capito";

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

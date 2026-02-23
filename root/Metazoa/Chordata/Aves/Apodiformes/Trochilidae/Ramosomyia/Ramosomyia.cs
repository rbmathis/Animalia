using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Ramosomyia;

/// <summary>
/// Abstract class for Ramosomyia (genus).
/// NCBI TaxId: 3150859
/// </summary>
public abstract class Ramosomyia : Trochilidae, IRamosomyia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ramosomyia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150859;

    /// <inheritdoc />
    public virtual string GenusName => "Ramosomyia";

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

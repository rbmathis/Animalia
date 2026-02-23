using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Elliotomyia;

/// <summary>
/// Abstract class for Elliotomyia (genus).
/// NCBI TaxId: 3150856
/// </summary>
public abstract class Elliotomyia : Trochilidae, IElliotomyia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elliotomyia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150856;

    /// <inheritdoc />
    public virtual string GenusName => "Elliotomyia";

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

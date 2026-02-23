using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Coracornis;

/// <summary>
/// Abstract class for Coracornis (genus).
/// NCBI TaxId: 498419
/// </summary>
public abstract class Coracornis : Corvidae, ICoracornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coracornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 498419;

    /// <inheritdoc />
    public virtual string GenusName => "Coracornis";

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

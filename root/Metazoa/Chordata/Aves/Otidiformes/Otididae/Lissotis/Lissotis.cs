using AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Lissotis;

/// <summary>
/// Abstract class for Lissotis (genus).
/// NCBI TaxId: 172681
/// </summary>
public abstract class Lissotis : Otididae, ILissotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lissotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172681;

    /// <inheritdoc />
    public virtual string GenusName => "Lissotis";

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

using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Hylacola;

/// <summary>
/// Abstract class for Hylacola (genus).
/// NCBI TaxId: 2821865
/// </summary>
public abstract class Hylacola : Acanthizidae, IHylacola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylacola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821865;

    /// <inheritdoc />
    public virtual string GenusName => "Hylacola";

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

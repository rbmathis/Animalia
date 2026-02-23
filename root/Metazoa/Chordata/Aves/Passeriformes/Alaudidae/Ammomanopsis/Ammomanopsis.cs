using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Ammomanopsis;

/// <summary>
/// Abstract class for Ammomanopsis (genus).
/// NCBI TaxId: 2820827
/// </summary>
public abstract class Ammomanopsis : Alaudidae, IAmmomanopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ammomanopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2820827;

    /// <inheritdoc />
    public virtual string GenusName => "Ammomanopsis";

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

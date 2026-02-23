using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Mirafra;

/// <summary>
/// Abstract class for Mirafra (genus).
/// NCBI TaxId: 215311
/// </summary>
public abstract class Mirafra : Alaudidae, IMirafra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mirafra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215311;

    /// <inheritdoc />
    public virtual string GenusName => "Mirafra";

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

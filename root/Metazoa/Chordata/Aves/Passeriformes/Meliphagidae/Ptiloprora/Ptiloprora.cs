using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Ptiloprora;

/// <summary>
/// Abstract class for Ptiloprora (genus).
/// NCBI TaxId: 9147
/// </summary>
public abstract class Ptiloprora : Meliphagidae, IPtiloprora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptiloprora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9147;

    /// <inheritdoc />
    public virtual string GenusName => "Ptiloprora";

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

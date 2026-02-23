using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Aidemosyne;

/// <summary>
/// Abstract class for Aidemosyne (genus).
/// NCBI TaxId: 247977
/// </summary>
public abstract class Aidemosyne : Estrildidae, IAidemosyne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aidemosyne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247977;

    /// <inheritdoc />
    public virtual string GenusName => "Aidemosyne";

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

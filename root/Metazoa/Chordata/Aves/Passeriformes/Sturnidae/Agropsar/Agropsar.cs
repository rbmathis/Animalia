using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Agropsar;

/// <summary>
/// Abstract class for Agropsar (genus).
/// NCBI TaxId: 2675478
/// </summary>
public abstract class Agropsar : Sturnidae, IAgropsar
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agropsar";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2675478;

    /// <inheritdoc />
    public virtual string GenusName => "Agropsar";

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

using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Creatophora;

/// <summary>
/// Abstract class for Creatophora (genus).
/// NCBI TaxId: 241775
/// </summary>
public abstract class Creatophora : Sturnidae, ICreatophora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Creatophora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241775;

    /// <inheritdoc />
    public virtual string GenusName => "Creatophora";

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

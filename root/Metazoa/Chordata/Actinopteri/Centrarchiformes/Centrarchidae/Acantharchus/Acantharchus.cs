using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Acantharchus;

/// <summary>
/// Abstract class for Acantharchus (genus).
/// NCBI TaxId: 201698
/// </summary>
public abstract class Acantharchus : Centrarchidae, IAcantharchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acantharchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201698;

    /// <inheritdoc />
    public virtual string GenusName => "Acantharchus";

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

using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Dermophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Dermophiidae.Schistometopum;

/// <summary>
/// Abstract class for Schistometopum (genus).
/// NCBI TaxId: 260981
/// </summary>
public abstract class Schistometopum : Dermophiidae, ISchistometopum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schistometopum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 260981;

    /// <inheritdoc />
    public virtual string GenusName => "Schistometopum";

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

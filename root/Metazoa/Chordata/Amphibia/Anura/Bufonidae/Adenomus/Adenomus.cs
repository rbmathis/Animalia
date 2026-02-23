using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Adenomus;

/// <summary>
/// Abstract class for Adenomus (genus).
/// NCBI TaxId: 420439
/// </summary>
public abstract class Adenomus : Bufonidae, IAdenomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Adenomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 420439;

    /// <inheritdoc />
    public virtual string GenusName => "Adenomus";

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

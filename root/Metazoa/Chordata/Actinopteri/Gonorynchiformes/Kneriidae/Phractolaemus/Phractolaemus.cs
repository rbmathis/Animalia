using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Kneriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Kneriidae.Phractolaemus;

/// <summary>
/// Abstract class for Phractolaemus (genus).
/// NCBI TaxId: 169290
/// </summary>
public abstract class Phractolaemus : Kneriidae, IPhractolaemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phractolaemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 169290;

    /// <inheritdoc />
    public virtual string GenusName => "Phractolaemus";

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

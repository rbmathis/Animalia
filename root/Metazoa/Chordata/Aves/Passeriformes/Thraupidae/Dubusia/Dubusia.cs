using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Dubusia;

/// <summary>
/// Abstract class for Dubusia (genus).
/// NCBI TaxId: 62194
/// </summary>
public abstract class Dubusia : Thraupidae, IDubusia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dubusia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62194;

    /// <inheritdoc />
    public virtual string GenusName => "Dubusia";

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

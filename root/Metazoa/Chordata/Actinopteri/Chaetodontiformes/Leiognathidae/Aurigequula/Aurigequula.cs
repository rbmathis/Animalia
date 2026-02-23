using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Aurigequula;

/// <summary>
/// Abstract class for Aurigequula (genus).
/// NCBI TaxId: 979558
/// </summary>
public abstract class Aurigequula : Leiognathidae, IAurigequula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aurigequula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 979558;

    /// <inheritdoc />
    public virtual string GenusName => "Aurigequula";

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

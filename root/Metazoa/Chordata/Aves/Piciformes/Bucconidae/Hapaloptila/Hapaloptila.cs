using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Hapaloptila;

/// <summary>
/// Abstract class for Hapaloptila (genus).
/// NCBI TaxId: 882741
/// </summary>
public abstract class Hapaloptila : Bucconidae, IHapaloptila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hapaloptila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882741;

    /// <inheritdoc />
    public virtual string GenusName => "Hapaloptila";

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

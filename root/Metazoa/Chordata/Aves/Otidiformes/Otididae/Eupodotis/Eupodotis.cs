using AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Eupodotis;

/// <summary>
/// Abstract class for Eupodotis (genus).
/// NCBI TaxId: 89384
/// </summary>
public abstract class Eupodotis : Otididae, IEupodotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eupodotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89384;

    /// <inheritdoc />
    public virtual string GenusName => "Eupodotis";

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

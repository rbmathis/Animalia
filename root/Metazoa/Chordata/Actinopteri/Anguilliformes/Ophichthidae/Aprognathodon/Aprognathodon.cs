using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Aprognathodon;

/// <summary>
/// Abstract class for Aprognathodon (genus).
/// NCBI TaxId: 1182207
/// </summary>
public abstract class Aprognathodon : Ophichthidae, IAprognathodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aprognathodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182207;

    /// <inheritdoc />
    public virtual string GenusName => "Aprognathodon";

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

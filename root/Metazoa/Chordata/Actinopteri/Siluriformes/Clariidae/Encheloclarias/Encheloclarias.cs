using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Encheloclarias;

/// <summary>
/// Abstract class for Encheloclarias (genus).
/// NCBI TaxId: 3021526
/// </summary>
public abstract class Encheloclarias : Clariidae, IEncheloclarias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Encheloclarias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3021526;

    /// <inheritdoc />
    public virtual string GenusName => "Encheloclarias";

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

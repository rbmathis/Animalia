using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae.Macquaria;

/// <summary>
/// Abstract class for Macquaria (genus).
/// NCBI TaxId: 45782
/// </summary>
public abstract class Macquaria : Percichthyidae, IMacquaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macquaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 45782;

    /// <inheritdoc />
    public virtual string GenusName => "Macquaria";

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

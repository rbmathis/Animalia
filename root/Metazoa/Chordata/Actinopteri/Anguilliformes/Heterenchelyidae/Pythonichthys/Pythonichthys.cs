using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Heterenchelyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Heterenchelyidae.Pythonichthys;

/// <summary>
/// Abstract class for Pythonichthys (genus).
/// NCBI TaxId: 556144
/// </summary>
public abstract class Pythonichthys : Heterenchelyidae, IPythonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pythonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 556144;

    /// <inheritdoc />
    public virtual string GenusName => "Pythonichthys";

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

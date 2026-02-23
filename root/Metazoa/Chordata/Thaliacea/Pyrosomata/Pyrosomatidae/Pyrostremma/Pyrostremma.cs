using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Pyrosomata.Pyrosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Pyrosomata.Pyrosomatidae.Pyrostremma;

/// <summary>
/// Abstract class for Pyrostremma (genus).
/// NCBI TaxId: 641101
/// </summary>
public abstract class Pyrostremma : Pyrosomatidae, IPyrostremma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrostremma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641101;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrostremma";

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

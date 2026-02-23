using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Stathmonotus;

/// <summary>
/// Abstract class for Stathmonotus (genus).
/// NCBI TaxId: 57857
/// </summary>
public abstract class Stathmonotus : Labrisomidae, IStathmonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stathmonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57857;

    /// <inheritdoc />
    public virtual string GenusName => "Stathmonotus";

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

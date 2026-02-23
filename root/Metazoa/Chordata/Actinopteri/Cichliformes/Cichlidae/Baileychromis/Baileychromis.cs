using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Baileychromis;

/// <summary>
/// Abstract class for Baileychromis (genus).
/// NCBI TaxId: 286573
/// </summary>
public abstract class Baileychromis : Cichlidae, IBaileychromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Baileychromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 286573;

    /// <inheritdoc />
    public virtual string GenusName => "Baileychromis";

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

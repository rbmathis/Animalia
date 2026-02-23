using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Rhinochimaeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Rhinochimaeridae.Rhinochimaera;

/// <summary>
/// Abstract class for Rhinochimaera (genus).
/// NCBI TaxId: 134993
/// </summary>
public abstract class Rhinochimaera : Rhinochimaeridae, IRhinochimaera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinochimaera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 134993;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinochimaera";

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
